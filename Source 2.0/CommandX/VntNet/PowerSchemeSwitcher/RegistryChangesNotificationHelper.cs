using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x020004C9 RID: 1225
	public sealed class RegistryChangesNotificationHelper
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06001FEB RID: 8171 RVA: 0x000D153C File Offset: 0x000CF73C
		// (remove) Token: 0x06001FEC RID: 8172 RVA: 0x000D1578 File Offset: 0x000CF778
		[CompilerGenerated]
		[method: CompilerGenerated]
		internal event Action RegistryChanged;

		// Token: 0x06001FED RID: 8173 RVA: 0x000D15B4 File Offset: 0x000CF7B4
		public RegistryChangesNotificationHelper(RegistryChangesNotificationHelper.HKeyEnum keyEnum, string subKeyPath, bool watchSubTree)
		{
			long key;
			if (keyEnum == RegistryChangesNotificationHelper.HKeyEnum.LocalMachine)
			{
				key = -2147483646L;
			}
			else
			{
				key = 0L;
			}
			this._native = new RegistryChangesNotificationHelper.RegNotificationNative(key, subKeyPath, watchSubTree);
			Application.ApplicationExit += new EventHandler(this.Application_ApplicationExit);
			ThreadPool.QueueUserWorkItem(delegate(object param0)
			{
				this.MonitorKeyFn();
			});
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00013380 File Offset: 0x00011580
		private void Application_ApplicationExit(object sender, EventArgs e)
		{
			this._exit = true;
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00013389 File Offset: 0x00011589
		private void OnRegistryChanged()
		{
			if (this.RegistryChanged != null)
			{
				this.RegistryChanged();
			}
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x000D1620 File Offset: 0x000CF820
		private void MonitorKeyFn()
		{
			while (!this._exit)
			{
				try
				{
					this._native.WaitForRegNotification();
					this.OnRegistryChanged();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x04000F21 RID: 3873
		private bool _exit;

		// Token: 0x04000F22 RID: 3874
		private RegistryChangesNotificationHelper.RegNotificationNative _native;

		// Token: 0x020004CA RID: 1226
		public enum HKeyEnum
		{
			// Token: 0x04000F25 RID: 3877
			LocalMachine
		}

		// Token: 0x020004CB RID: 1227
		private sealed class RegNotificationNative
		{
			// Token: 0x14000006 RID: 6
			// (add) Token: 0x06001FF2 RID: 8178 RVA: 0x000D1664 File Offset: 0x000CF864
			// (remove) Token: 0x06001FF3 RID: 8179 RVA: 0x000D16A0 File Offset: 0x000CF8A0
			[CompilerGenerated]
			[method: CompilerGenerated]
			internal event Action RegNotifyChangeKeyValueEvent;

			// Token: 0x06001FF4 RID: 8180
			[DllImport("kernel32.dll")]
			private static extern IntPtr CreateEvent(IntPtr eventAttributes, bool manualReset, bool initialState, string name);

			// Token: 0x06001FF5 RID: 8181
			[DllImport("advapi32.dll")]
			private static extern IntPtr RegOpenKey(IntPtr key, string subKey, out IntPtr resultSubKey);

			// Token: 0x06001FF6 RID: 8182
			[DllImport("advapi32.dll")]
			private static extern long RegNotifyChangeKeyValue(IntPtr key, bool watchSubTree, int notifyFilter, IntPtr regEvent, bool async);

			// Token: 0x06001FF7 RID: 8183
			[DllImport("kernel32.dll")]
			private static extern long WaitForSingleObject(IntPtr handle, int timeOut);

			// Token: 0x06001FF8 RID: 8184
			[DllImport("kernel32.dll")]
			private static extern IntPtr CloseHandle(IntPtr handle);

			// Token: 0x06001FF9 RID: 8185 RVA: 0x000133A9 File Offset: 0x000115A9
			internal RegNotificationNative(long key, string subKey, bool watchSubTree)
			{
				this._watchSubTree = watchSubTree;
				this._keyChangedEvent = RegistryChangesNotificationHelper.RegNotificationNative.CreateEvent((IntPtr)null, false, false, null);
				RegistryChangesNotificationHelper.RegNotificationNative.RegOpenKey(new IntPtr((int)key), subKey, out this._monitoredKey);
				this.CallRegNotifyChangeKeyValue();
			}

			// Token: 0x06001FFA RID: 8186 RVA: 0x000133E7 File Offset: 0x000115E7
			private void CallRegNotifyChangeKeyValue()
			{
				RegistryChangesNotificationHelper.RegNotificationNative.RegNotifyChangeKeyValue(this._monitoredKey, this._watchSubTree, 5, this._keyChangedEvent, true);
			}

			// Token: 0x06001FFB RID: 8187 RVA: 0x00013403 File Offset: 0x00011603
			internal void WaitForRegNotification()
			{
				RegistryChangesNotificationHelper.RegNotificationNative.WaitForSingleObject(this._keyChangedEvent, -1);
				this.RegNotifyChangeKeyValue();
				this.CallRegNotifyChangeKeyValue();
			}

			// Token: 0x06001FFC RID: 8188 RVA: 0x0001341E File Offset: 0x0001161E
			private void RegNotifyChangeKeyValue()
			{
				if (this.RegNotifyChangeKeyValueEvent != null)
				{
					this.RegNotifyChangeKeyValueEvent();
				}
			}

			// Token: 0x04000F26 RID: 3878
			private const int INFINITE = -1;

			// Token: 0x04000F27 RID: 3879
			internal const long HKEY_LOCAL_MACHINE = 2147483650L;

			// Token: 0x04000F28 RID: 3880
			private const long REG_NOTIFY_CHANGE_NAME = 1L;

			// Token: 0x04000F29 RID: 3881
			private const long REG_NOTIFY_CHANGE_ATTRIBUTES = 2L;

			// Token: 0x04000F2A RID: 3882
			private const long REG_NOTIFY_CHANGE_LAST_SET = 4L;

			// Token: 0x04000F2B RID: 3883
			private const long REG_NOTIFY_CHANGE_SECURITY = 8L;

			// Token: 0x04000F2C RID: 3884
			private IntPtr _monitoredKey;

			// Token: 0x04000F2D RID: 3885
			private IntPtr _keyChangedEvent;

			// Token: 0x04000F2E RID: 3886
			private bool _watchSubTree;
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace VntNet.PowerSchemeSwitcher
{
	// Token: 0x0200050C RID: 1292
	public sealed class PowerSchemeHelper
	{
		// Token: 0x060021B2 RID: 8626 RVA: 0x000DC004 File Offset: 0x000DA204
		public static bool SetPowerScheme(Guid schemeGuid)
		{
			bool result;
			if (PowerSchemeHelper.PowrProfHelper.GetPowerActiveScheme() == schemeGuid)
			{
				result = true;
			}
			else
			{
				PowerSchemeHelper.PowrProfHelper.SetPowerScheme(schemeGuid);
				result = (PowerSchemeHelper.PowrProfHelper.GetPowerActiveScheme() == schemeGuid);
			}
			return result;
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x000DC03C File Offset: 0x000DA23C
		public static Dictionary<Guid, PowerPlanInfo> GetAllPowerSchemas()
		{
			uint num = 0u;
			Dictionary<Guid, PowerPlanInfo> dictionary = new Dictionary<Guid, PowerPlanInfo>(3);
			while (true)
			{
				try
				{
					Guid powerSchemeGuid = PowerSchemeHelper.PowrProfHelper.GetPowerSchemeGuid(num);
					if (!(powerSchemeGuid != Guid.Empty))
					{
						break;
					}
					string powerSchemeFriendlyName = PowerSchemeHelper.PowrProfHelper.GetPowerSchemeFriendlyName(powerSchemeGuid);
					dictionary.Add(powerSchemeGuid, new PowerPlanInfo
					{
						SchemeGuid = powerSchemeGuid,
						FriendlyName = powerSchemeFriendlyName
					});
				}
				finally
				{
					num += 1u;
				}
			}
			return dictionary;
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x000DC0B0 File Offset: 0x000DA2B0
		public static Guid GetPowerActiveScheme()
		{
			return PowerSchemeHelper.PowrProfHelper.GetPowerActiveScheme();
		}

		// Token: 0x0200050D RID: 1293
		private sealed class PowrProfHelper
		{
			// Token: 0x060021B6 RID: 8630
			[DllImport("PowrProf.dll", CharSet = CharSet.Auto, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.U4)]
			private static extern uint PowerEnumerate(IntPtr RootPowerKey, IntPtr SchemeGuid, IntPtr SubGroupOfPowerSettingsGuid, PowerSchemeHelper.PowrProfHelper.POWER_DATA_ACCESSOR AccessFlags, uint Index, IntPtr Buffer, ref uint BufferSize);

			// Token: 0x060021B7 RID: 8631
			[DllImport("PowrProf.dll", CharSet = CharSet.Auto, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.U4)]
			private static extern uint PowerReadFriendlyName(IntPtr RootPowerKey, ref Guid SchemeGuid, IntPtr SubGroupOfPowerSettingsGuid, IntPtr PowerSettingGuid, IntPtr Buffer, ref uint BufferSize);

			// Token: 0x060021B8 RID: 8632
			[DllImport("PowrProf.dll", CharSet = CharSet.Auto, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.U4)]
			private static extern uint PowerSetActiveScheme(IntPtr UserRootPowerKey, ref Guid SchemeGuid);

			// Token: 0x060021B9 RID: 8633
			[DllImport("PowrProf.dll", CharSet = CharSet.Auto, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.U4)]
			private static extern uint PowerGetActiveScheme(IntPtr UserRootPowerKey, ref IntPtr ActivePolicyGuid);

			// Token: 0x060021BA RID: 8634 RVA: 0x000DC0C4 File Offset: 0x000DA2C4
			public static Guid GetPowerSchemeGuid(uint index)
			{
				uint cb = 16u;
				Guid result = Guid.Empty;
				IntPtr intPtr = intPtr = Marshal.AllocHGlobal(16);
				try
				{
					uint num = PowerSchemeHelper.PowrProfHelper.PowerEnumerate(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, PowerSchemeHelper.PowrProfHelper.POWER_DATA_ACCESSOR.ACCESS_SCHEME, index, intPtr, ref cb);
					if (num == 234u)
					{
						Marshal.FreeHGlobal(intPtr);
						intPtr = Marshal.AllocHGlobal((int)cb);
						num = PowerSchemeHelper.PowrProfHelper.PowerEnumerate(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, PowerSchemeHelper.PowrProfHelper.POWER_DATA_ACCESSOR.ACCESS_SCHEME, index, intPtr, ref cb);
					}
					if (num == 0u)
					{
						result = (Guid)Marshal.PtrToStructure(intPtr, typeof(Guid));
					}
					else if (num != 259u)
					{
						throw new Win32Exception(Marshal.GetLastWin32Error());
					}
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr);
				}
				return result;
			}

			// Token: 0x060021BB RID: 8635 RVA: 0x000DC188 File Offset: 0x000DA388
			public static string GetPowerSchemeFriendlyName(Guid schemeGuid)
			{
				uint cb = 255u;
				IntPtr intPtr = Marshal.AllocHGlobal(255);
				uint num = PowerSchemeHelper.PowrProfHelper.PowerReadFriendlyName(IntPtr.Zero, ref schemeGuid, IntPtr.Zero, IntPtr.Zero, intPtr, ref cb);
				if (num == 234u)
				{
					Marshal.FreeHGlobal(intPtr);
					intPtr = Marshal.AllocHGlobal((int)cb);
					num = PowerSchemeHelper.PowrProfHelper.PowerReadFriendlyName(IntPtr.Zero, ref schemeGuid, IntPtr.Zero, IntPtr.Zero, intPtr, ref cb);
				}
				string result;
				if (num == 0u)
				{
					result = Marshal.PtrToStringUni(intPtr);
				}
				else
				{
					if (num != 2u)
					{
						throw new Win32Exception(Marshal.GetLastWin32Error());
					}
					result = null;
				}
				Marshal.FreeHGlobal(intPtr);
				return result;
			}

			// Token: 0x060021BC RID: 8636 RVA: 0x0001412A File Offset: 0x0001232A
			public static bool SetPowerScheme(Guid schemeGuid)
			{
				return PowerSchemeHelper.PowrProfHelper.PowerSetActiveScheme(IntPtr.Zero, ref schemeGuid) == 0u;
			}

			// Token: 0x060021BD RID: 8637 RVA: 0x000DC22C File Offset: 0x000DA42C
			public static Guid GetPowerActiveScheme()
			{
				IntPtr intPtr = Marshal.AllocHGlobal(16);
				Guid result = Guid.Empty;
				if (PowerSchemeHelper.PowrProfHelper.PowerGetActiveScheme(IntPtr.Zero, ref intPtr) == 0u)
				{
					result = (Guid)Marshal.PtrToStructure(intPtr, typeof(Guid));
				}
				Marshal.FreeHGlobal(intPtr);
				return result;
			}

			// Token: 0x0400104B RID: 4171
			private const uint ERROR_SUCCESS = 0u;

			// Token: 0x0400104C RID: 4172
			private const uint ERROR_MORE_DATA = 234u;

			// Token: 0x0400104D RID: 4173
			private const uint ERROR_NO_MORE_ITEMS = 259u;

			// Token: 0x0400104E RID: 4174
			private const uint ERROR_FILE_NOT_FOUND = 2u;

			// Token: 0x0200050E RID: 1294
			[Flags]
			private enum POWER_DATA_ACCESSOR
			{
				// Token: 0x04001050 RID: 4176
				ACCESS_AC_POWER_SETTING_INDEX = 0,
				// Token: 0x04001051 RID: 4177
				ACCESS_DC_POWER_SETTING_INDEX = 1,
				// Token: 0x04001052 RID: 4178
				ACCESS_SCHEME = 16,
				// Token: 0x04001053 RID: 4179
				ACCESS_ACTIVE_SCHEME = 19,
				// Token: 0x04001054 RID: 4180
				ACCESS_CREATE_SCHEME = 20
			}
		}
	}
}

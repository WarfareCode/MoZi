using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using VntNet.PowerSchemeSwitcher;

namespace ns33
{
	// Token: 0x02000972 RID: 2418
	public sealed class PowerSchemeManager
	{
		// Token: 0x06003B76 RID: 15222 RVA: 0x00126228 File Offset: 0x00124428
		public static void smethod_0()
		{
			try
			{
				PowerSchemeManager.guid_0 = PowerSchemeHelper.GetPowerActiveScheme();
				Dictionary<Guid, PowerPlanInfo> allPowerSchemas = PowerSchemeHelper.GetAllPowerSchemas();
				foreach (KeyValuePair<Guid, PowerPlanInfo> current in allPowerSchemas)
				{
					if (Operators.CompareString(current.Value.FriendlyName.ToUpper(), "HIGH PERFORMANCE", false) == 0 && !(current.Key == PowerSchemeManager.guid_0))
					{
						PowerSchemeHelper.SetPowerScheme(current.Key);
						break;
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x001262E0 File Offset: 0x001244E0
		public static void RestorePowerScheme()
		{
			try
			{
				if (!Information.IsNothing(PowerSchemeManager.guid_0) && !(PowerSchemeHelper.GetPowerActiveScheme() == PowerSchemeManager.guid_0))
				{
					PowerSchemeHelper.SetPowerScheme(PowerSchemeManager.guid_0);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x000142D0 File Offset: 0x000124D0
		public static bool Win32NTVersion6Above()
		{
			return Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6;
		}

		// Token: 0x04001B2D RID: 6957
		private static Guid guid_0;
	}
}

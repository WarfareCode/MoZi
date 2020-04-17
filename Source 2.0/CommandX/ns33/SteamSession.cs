using System;
using Steamworks;

namespace ns33
{
	// Token: 0x02000973 RID: 2419
	public sealed class SteamSession
	{
		// Token: 0x06003B7A RID: 15226 RVA: 0x0001F8A8 File Offset: 0x0001DAA8
		public static void Shutdown()
		{
			if (SteamSession.bool_0)
			{
				SteamAPI.Shutdown();
			}
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x0001F8B9 File Offset: 0x0001DAB9
		public static void Init()
		{
			if (!SteamSession.bool_1)
			{
				SteamSession.bool_0 = SteamAPI.Init();
				SteamSession.bool_1 = true;
			}
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x00126340 File Offset: 0x00124540
		public static bool Authenticate(AppId_t appId_t_0)
		{
			if (!SteamSession.bool_0 && !SteamSession.bool_1)
			{
				SteamSession.Init();
			}
			bool result;
			if (SteamSession.bool_0)
			{
				if (SteamApps.BIsSubscribedApp(appId_t_0))
				{
					result = true;
					return result;
				}
			}
			else
			{
				byte[] array = new byte[1025];
				uint num;
				if (SteamUser.GetAuthSessionTicket(array, 1024, out num) != HAuthTicket.Invalid & (ulong)num > 0uL)
				{
					SteamUser.BeginAuthSession(array, (int)num, SteamUser.GetSteamID());
					SteamUser.UserHasLicenseForApp(SteamUser.GetSteamID(), appId_t_0);
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x001263D0 File Offset: 0x001245D0
		public static bool smethod_3(AppId_t appId_t_0)
		{
			if (!SteamSession.bool_0 && !SteamSession.bool_1)
			{
				SteamSession.Init();
			}
			bool result;
			if (SteamSession.bool_0)
			{
				if (SteamApps.BIsDlcInstalled(appId_t_0))
				{
					result = true;
					return result;
				}
			}
			else
			{
				byte[] array = new byte[1025];
				uint num;
				if (SteamUser.GetAuthSessionTicket(array, 1024, out num) != HAuthTicket.Invalid & (ulong)num > 0uL)
				{
					SteamUser.BeginAuthSession(array, (int)num, SteamUser.GetSteamID());
					SteamUser.UserHasLicenseForApp(SteamUser.GetSteamID(), appId_t_0);
				}
			}
			result = false;
			return result;
		}

		// Token: 0x04001B2E RID: 6958
		public static bool bool_0;

		// Token: 0x04001B2F RID: 6959
		private static bool bool_1 = false;
	}
}

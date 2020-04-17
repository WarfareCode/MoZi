using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns34;
using ns35;
using Steamworks;

namespace ns33
{
	// Token: 0x02000992 RID: 2450
	public sealed class SteamWorkshop
	{
		// Token: 0x06003DFF RID: 15871 RVA: 0x00143F20 File Offset: 0x00142120
		public static void smethod_0(SteamWorkshop.Class2504 class2504_1, SteamUGCDetails_t steamUGCDetails_t_0)
		{
			if (!SteamSession.bool_0)
			{
				throw new Exception33();
			}
			CommandFactory.GetCommandMain().GetSteamUpdateScenarioForm().Enabled = false;
			SteamWorkshop.class2504_0 = class2504_1;
			if (SteamWorkshop.class2504_0.string_0.Length > 120)
			{
				SteamWorkshop.class2504_0.string_0 = SteamWorkshop.class2504_0.string_0.Take(127).ToString();
			}
			if (SteamWorkshop.class2504_0.string_1.Length > 7500)
			{
				SteamWorkshop.class2504_0.string_1 = SteamWorkshop.class2504_0.string_1.Take(7999).ToString();
			}
			SteamWorkshop.class2504_0.list_0 = new List<string>();
			SteamWorkshop.class2504_0.list_0.Add("Scenario");
			if (string.IsNullOrEmpty(SteamWorkshop.class2504_0.string_0))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(SteamWorkshop.class2504_0.string_1))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(SteamWorkshop.class2504_0.string_2))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(SteamWorkshop.class2504_0.string_3))
			{
				throw new ArgumentNullException();
			}
			SteamWorkshop.class2504_0.string_4 = Path.Combine(new string[]
			{
				Path.GetTempPath() + SteamWorkshop.class2504_0.string_2
			});
			Directory.CreateDirectory(SteamWorkshop.class2504_0.string_4);
			Directory.CreateDirectory(Path.Combine(SteamWorkshop.class2504_0.string_4, "attachments"));
			Client.SaveTempScenarioFile(false, Path.Combine(SteamWorkshop.class2504_0.string_4, SteamWorkshop.class2504_0.string_2 + ".scen"), false);
			SteamWorkshop.class2504_0.string_3 = Path.GetFullPath(SteamWorkshop.class2504_0.string_3);
			foreach (KeyValuePair<string, ScenAttachmentObject> current in Client.GetClientScenario().GetScenAttachments())
			{
				if (Directory.Exists(Path.Combine(GameGeneral.strAttachmentRepoDir, current.Key)))
				{
					Misc.smethod_2(Path.Combine(GameGeneral.strAttachmentRepoDir, current.Key), Path.Combine(SteamWorkshop.class2504_0.string_4, "\\attachments", current.Key), true);
				}
			}
			UGCUpdateHandle_t uGCUpdateHandle_t = SteamUGC.StartItemUpdate(LicenseChecker.appId_t_0, steamUGCDetails_t_0.m_nPublishedFileId);
			SteamUGC.SetItemTitle(uGCUpdateHandle_t, SteamWorkshop.class2504_0.string_0);
			SteamUGC.SetItemDescription(uGCUpdateHandle_t, SteamWorkshop.class2504_0.string_1);
			SteamUGC.SetItemVisibility(uGCUpdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);
			SteamUGC.SetItemTags(uGCUpdateHandle_t, SteamWorkshop.class2504_0.list_0);
			SteamUGC.SetItemContent(uGCUpdateHandle_t, SteamWorkshop.class2504_0.string_4);
			SteamUGC.SetItemPreview(uGCUpdateHandle_t, SteamWorkshop.class2504_0.string_3);
			SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(uGCUpdateHandle_t, "Update");
			SteamWorkshop.callResult_1.Set(hAPICall, null);
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x00144204 File Offset: 0x00142404
		public static void smethod_1(SteamWorkshop.Class2504 class2504_1)
		{
			if (!SteamSession.bool_0)
			{
				throw new Exception33();
			}
			CommandFactory.GetCommandMain().GetSteamPublishScenarioForm().Enabled = false;
			SteamWorkshop.class2504_0 = class2504_1;
			if (SteamWorkshop.class2504_0.string_0.Length > 120)
			{
				SteamWorkshop.class2504_0.string_0 = SteamWorkshop.class2504_0.string_0.Take(127).ToString();
			}
			if (SteamWorkshop.class2504_0.string_1.Length > 7500)
			{
				SteamWorkshop.class2504_0.string_1 = SteamWorkshop.class2504_0.string_1.Take(7999).ToString();
			}
			SteamWorkshop.class2504_0.list_0 = new List<string>();
			SteamWorkshop.class2504_0.list_0.Add("Scenario");
			if (string.IsNullOrEmpty(SteamWorkshop.class2504_0.string_0))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(SteamWorkshop.class2504_0.string_1))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(SteamWorkshop.class2504_0.string_2))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(SteamWorkshop.class2504_0.string_3))
			{
				throw new ArgumentNullException();
			}
			SteamWorkshop.class2504_0.string_4 = Path.Combine(new string[]
			{
				Path.GetTempPath() + SteamWorkshop.class2504_0.string_2
			});
			Directory.CreateDirectory(SteamWorkshop.class2504_0.string_4);
			Directory.CreateDirectory(Path.Combine(SteamWorkshop.class2504_0.string_4, "attachments"));
			Client.SaveTempScenarioFile(false, Path.Combine(SteamWorkshop.class2504_0.string_4, SteamWorkshop.class2504_0.string_2 + ".scen"), false);
			SteamWorkshop.class2504_0.string_3 = Path.GetFullPath(SteamWorkshop.class2504_0.string_3);
			foreach (KeyValuePair<string, ScenAttachmentObject> current in Client.GetClientScenario().GetScenAttachments())
			{
				if (Directory.Exists(Path.Combine(GameGeneral.strAttachmentRepoDir, current.Key)))
				{
					Misc.smethod_2(Path.Combine(GameGeneral.strAttachmentRepoDir, current.Key), Path.Combine(SteamWorkshop.class2504_0.string_4, "\\attachments", current.Key), true);
				}
			}
			SteamAPICall_t hAPICall = SteamUGC.CreateItem(LicenseChecker.appId_t_0, EWorkshopFileType.k_EWorkshopFileTypeFirst);
			SteamWorkshop.callResult_0.Set(hAPICall, null);
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00144478 File Offset: 0x00142678
		public static void smethod_2()
		{
			if (SteamSession.bool_0)
			{
				SteamWorkshop.callResult_0 = new CallResult<CreateItemResult_t>(new CallResult<CreateItemResult_t>.APIDispatchDelegate(SteamWorkshop.smethod_11));
				SteamWorkshop.callResult_1 = new CallResult<SubmitItemUpdateResult_t>(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(SteamWorkshop.UploadScenarioToSteam));
				SteamWorkshop.callResult_2 = new CallResult<RemoteStoragePublishedFileSubscribed_t>(new CallResult<RemoteStoragePublishedFileSubscribed_t>.APIDispatchDelegate(SteamWorkshop.smethod_12));
				SteamWorkshop.callResult_3 = new CallResult<RemoteStoragePublishedFileUnsubscribed_t>(new CallResult<RemoteStoragePublishedFileUnsubscribed_t>.APIDispatchDelegate(SteamWorkshop.smethod_13));
				SteamWorkshop.callResult_4 = new CallResult<ItemInstalled_t>(new CallResult<ItemInstalled_t>.APIDispatchDelegate(SteamWorkshop.smethod_14));
				SteamWorkshop.callResult_5 = new CallResult<DownloadItemResult_t>(new CallResult<DownloadItemResult_t>.APIDispatchDelegate(SteamWorkshop.smethod_9));
				SteamWorkshop.callResult_6 = new CallResult<SteamUGCQueryCompleted_t>(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(SteamWorkshop.smethod_8));
				SteamWorkshop.smethod_3();
				SteamWorkshop.smethod_7();
			}
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x00144538 File Offset: 0x00142738
		public static void smethod_3()
		{
			object obj = SteamWorkshop.object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			lock (obj)
			{
				if (SteamSession.bool_0)
				{
					uint numSubscribedItems = SteamUGC.GetNumSubscribedItems();
					PublishedFileId_t[] array = new PublishedFileId_t[numSubscribedItems + 1u];
					SteamUGC.GetSubscribedItems(array, numSubscribedItems);
					SteamWorkshop.list_0 = array.ToList<PublishedFileId_t>();
					List<SteamWorkshop.Class2503> list = new List<SteamWorkshop.Class2503>();
					foreach (PublishedFileId_t current in SteamWorkshop.list_0)
					{
						list.Add(new SteamWorkshop.Class2503(current));
					}
					SteamWorkshop.list_1 = list;
					foreach (SteamWorkshop.Class2503 current2 in SteamWorkshop.list_1)
					{
						if (current2.method_13())
						{
							current2.method_22();
						}
					}
					SteamWorkshop.smethod_7();
				}
			}
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x0014465C File Offset: 0x0014285C
		private static void smethod_4(PublishedFileId_t publishedFileId_t_0)
		{
			SteamWorkshop.Class2503 @class = new SteamWorkshop.Class2503(publishedFileId_t_0);
			if (@class.method_13())
			{
				@class.method_22();
			}
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x00020302 File Offset: 0x0001E502
		public static void smethod_5()
		{
			if (SteamSession.bool_0)
			{
				SteamAPI.RunCallbacks();
			}
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x00020313 File Offset: 0x0001E513
		private static void smethod_6(object object_1, bool bool_0)
		{
			if (!SteamSession.bool_0)
			{
				throw new Exception33();
			}
			if (bool_0)
			{
				throw new Exception32("IO Failure");
			}
			if (object_1 == null)
			{
				throw new Exception32("Null callback object");
			}
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x00144684 File Offset: 0x00142884
		public static void smethod_7()
		{
			SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Published, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_TitleAsc, LicenseChecker.appId_t_0, LicenseChecker.appId_t_0, 1u));
			SteamWorkshop.callResult_6.Set(hAPICall, null);
			SteamWorkshop.list_2 = new List<SteamUGCDetails_t>();
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x001446D0 File Offset: 0x001428D0
		private static void smethod_8(SteamUGCQueryCompleted_t steamUGCQueryCompleted_t_0, bool bool_0)
		{
			SteamWorkshop.smethod_6(steamUGCQueryCompleted_t_0, bool_0);
			uint unNumResultsReturned = steamUGCQueryCompleted_t_0.m_unNumResultsReturned;
			for (uint num = 0u; num <= unNumResultsReturned; num += 1u)
			{
				SteamWorkshop.Class2505 @class = new SteamWorkshop.Class2505(null);
				@class.steamUGCDetails_t_0 = default(SteamUGCDetails_t);
				SteamUGC.GetQueryUGCResult(steamUGCQueryCompleted_t_0.m_handle, num, out @class.steamUGCDetails_t_0);
				if (!SteamWorkshop.list_2.Any(new Func<SteamUGCDetails_t, bool>(@class.method_0)))
				{
					SteamWorkshop.list_2.Add(@class.steamUGCDetails_t_0);
				}
			}
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x00020347 File Offset: 0x0001E547
		private static void smethod_9(DownloadItemResult_t downloadItemResult_t_1, bool bool_0)
		{
			SteamWorkshop.smethod_6(downloadItemResult_t_1, bool_0);
			if (downloadItemResult_t_1.m_unAppID.m_AppId == LicenseChecker.appId_t_0.m_AppId)
			{
				SteamWorkshop.downloadItemResult_t_0 = downloadItemResult_t_1;
				SteamWorkshop.smethod_4(downloadItemResult_t_1.m_nPublishedFileId);
			}
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x00144754 File Offset: 0x00142954
		private static void UploadScenarioToSteam(SubmitItemUpdateResult_t submitItemUpdateResult_t_1, bool bool_0)
		{
			SteamWorkshop.smethod_6(submitItemUpdateResult_t_1, bool_0);
			SteamWorkshop.submitItemUpdateResult_t_0 = submitItemUpdateResult_t_1;
			if (SteamWorkshop.submitItemUpdateResult_t_0.m_eResult == EResult.k_EResultOK)
			{
				Interaction.MsgBox("The scenario has been successfully uploaded to Steam!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				Interaction.MsgBox("There was a problem in uploading the scenario to Steam. The error code was: " + SteamWorkshop.submitItemUpdateResult_t_0.m_eResult.ToString(), MsgBoxStyle.OkOnly, null);
			}
			if (SteamWorkshop.submitItemUpdateResult_t_0.m_bUserNeedsToAcceptWorkshopLegalAgreement)
			{
				Process.Start("http: //steamcommunity.com/sharedfiles/workshoplegalagreement");
				Interaction.MsgBox("Please accept Steam Workshop Legal Agreement.", MsgBoxStyle.OkOnly, null);
			}
			if (!Information.IsNothing(CommandFactory.GetCommandMain().GetSteamPublishScenarioForm()))
			{
				CommandFactory.GetCommandMain().GetSteamPublishScenarioForm().Enabled = true;
				CommandFactory.GetCommandMain().GetSteamPublishScenarioForm().Close();
			}
			if (!Information.IsNothing(CommandFactory.GetCommandMain().GetSteamUpdateScenarioForm()))
			{
				CommandFactory.GetCommandMain().GetSteamUpdateScenarioForm().Enabled = true;
				CommandFactory.GetCommandMain().GetSteamUpdateScenarioForm().Close();
			}
			if (Directory.Exists(SteamWorkshop.class2504_0.string_4))
			{
				try
				{
					Directory.Delete(SteamWorkshop.class2504_0.string_4, true);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 200423", ex2.Message);
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x001448B4 File Offset: 0x00142AB4
		private static void smethod_11(CreateItemResult_t createItemResult_t_1, bool bool_0)
		{
			SteamWorkshop.smethod_6(createItemResult_t_1, bool_0);
			SteamWorkshop.createItemResult_t_0 = createItemResult_t_1;
			if (SteamWorkshop.createItemResult_t_0.m_bUserNeedsToAcceptWorkshopLegalAgreement)
			{
				Process.Start("http://steamcommunity.com/sharedfiles/workshoplegalagreement");
				Interaction.MsgBox("Please accept Steam Workshop Legal Agreement.", MsgBoxStyle.OkOnly, null);
			}
			UGCUpdateHandle_t uGCUpdateHandle_t = SteamUGC.StartItemUpdate(LicenseChecker.appId_t_0, SteamWorkshop.createItemResult_t_0.m_nPublishedFileId);
			SteamUGC.SetItemTitle(uGCUpdateHandle_t, SteamWorkshop.class2504_0.string_0);
			SteamUGC.SetItemDescription(uGCUpdateHandle_t, SteamWorkshop.class2504_0.string_1);
			SteamUGC.SetItemVisibility(uGCUpdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);
			SteamUGC.SetItemTags(uGCUpdateHandle_t, SteamWorkshop.class2504_0.list_0);
			SteamUGC.SetItemContent(uGCUpdateHandle_t, SteamWorkshop.class2504_0.string_4);
			SteamUGC.SetItemPreview(uGCUpdateHandle_t, SteamWorkshop.class2504_0.string_3);
			SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(uGCUpdateHandle_t, "Initial Upload");
			SteamWorkshop.callResult_1.Set(hAPICall, null);
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x00020384 File Offset: 0x0001E584
		private static void smethod_12(RemoteStoragePublishedFileSubscribed_t remoteStoragePublishedFileSubscribed_t_1, bool bool_0)
		{
			SteamWorkshop.smethod_6(remoteStoragePublishedFileSubscribed_t_1, bool_0);
			SteamWorkshop.remoteStoragePublishedFileSubscribed_t_0 = remoteStoragePublishedFileSubscribed_t_1;
			SteamWorkshop.smethod_4(remoteStoragePublishedFileSubscribed_t_1.m_nPublishedFileId);
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x000203A4 File Offset: 0x0001E5A4
		private static void smethod_13(RemoteStoragePublishedFileUnsubscribed_t remoteStoragePublishedFileUnsubscribed_t_1, bool bool_0)
		{
			SteamWorkshop.smethod_6(remoteStoragePublishedFileUnsubscribed_t_1, bool_0);
			SteamWorkshop.remoteStoragePublishedFileUnsubscribed_t_0 = remoteStoragePublishedFileUnsubscribed_t_1;
			SteamWorkshop.smethod_4(remoteStoragePublishedFileUnsubscribed_t_1.m_nPublishedFileId);
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x000203C4 File Offset: 0x0001E5C4
		private static void smethod_14(ItemInstalled_t itemInstalled_t_1, bool bool_0)
		{
			SteamWorkshop.smethod_6(itemInstalled_t_1, bool_0);
			if (itemInstalled_t_1.m_unAppID.m_AppId == LicenseChecker.appId_t_0.m_AppId)
			{
				SteamWorkshop.itemInstalled_t_0 = itemInstalled_t_1;
				SteamWorkshop.smethod_4(itemInstalled_t_1.m_nPublishedFileId);
			}
		}

		// Token: 0x04001C6E RID: 7278
		public static SteamWorkshop.Class2504 class2504_0;

		// Token: 0x04001C6F RID: 7279
		private static List<PublishedFileId_t> list_0;

		// Token: 0x04001C70 RID: 7280
		public static List<SteamWorkshop.Class2503> list_1 = new List<SteamWorkshop.Class2503>();

		// Token: 0x04001C71 RID: 7281
		private static CallResult<CreateItemResult_t> callResult_0;

		// Token: 0x04001C72 RID: 7282
		private static CreateItemResult_t createItemResult_t_0;

		// Token: 0x04001C73 RID: 7283
		private static CallResult<SubmitItemUpdateResult_t> callResult_1;

		// Token: 0x04001C74 RID: 7284
		private static SubmitItemUpdateResult_t submitItemUpdateResult_t_0;

		// Token: 0x04001C75 RID: 7285
		private static CallResult<RemoteStoragePublishedFileSubscribed_t> callResult_2;

		// Token: 0x04001C76 RID: 7286
		private static RemoteStoragePublishedFileSubscribed_t remoteStoragePublishedFileSubscribed_t_0;

		// Token: 0x04001C77 RID: 7287
		private static CallResult<RemoteStoragePublishedFileUnsubscribed_t> callResult_3;

		// Token: 0x04001C78 RID: 7288
		private static RemoteStoragePublishedFileUnsubscribed_t remoteStoragePublishedFileUnsubscribed_t_0;

		// Token: 0x04001C79 RID: 7289
		private static CallResult<ItemInstalled_t> callResult_4;

		// Token: 0x04001C7A RID: 7290
		private static ItemInstalled_t itemInstalled_t_0;

		// Token: 0x04001C7B RID: 7291
		private static CallResult<DownloadItemResult_t> callResult_5;

		// Token: 0x04001C7C RID: 7292
		private static DownloadItemResult_t downloadItemResult_t_0;

		// Token: 0x04001C7D RID: 7293
		private static CallResult<SteamUGCQueryCompleted_t> callResult_6;

		// Token: 0x04001C7E RID: 7294
		private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04001C7F RID: 7295
		public static List<SteamUGCDetails_t> list_2 = new List<SteamUGCDetails_t>();

		// Token: 0x02000993 RID: 2451
		public sealed class Class2503
		{
			// Token: 0x06003E10 RID: 15888 RVA: 0x00020426 File Offset: 0x0001E626
			[CompilerGenerated]
			public void method_0(bool bool_8)
			{
				this.bool_0 = bool_8;
			}

			// Token: 0x06003E11 RID: 15889 RVA: 0x0002042F File Offset: 0x0001E62F
			[CompilerGenerated]
			public bool method_1()
			{
				return this.bool_1;
			}

			// Token: 0x06003E12 RID: 15890 RVA: 0x00020437 File Offset: 0x0001E637
			[CompilerGenerated]
			public void method_2(bool bool_8)
			{
				this.bool_1 = bool_8;
			}

			// Token: 0x06003E13 RID: 15891 RVA: 0x00020440 File Offset: 0x0001E640
			[CompilerGenerated]
			public bool method_3()
			{
				return this.bool_2;
			}

			// Token: 0x06003E14 RID: 15892 RVA: 0x00020448 File Offset: 0x0001E648
			[CompilerGenerated]
			public void method_4(bool bool_8)
			{
				this.bool_2 = bool_8;
			}

			// Token: 0x06003E15 RID: 15893 RVA: 0x00020451 File Offset: 0x0001E651
			[CompilerGenerated]
			public void method_5(bool bool_8)
			{
				this.bool_3 = bool_8;
			}

			// Token: 0x06003E16 RID: 15894 RVA: 0x0002045A File Offset: 0x0001E65A
			[CompilerGenerated]
			public void method_6(bool bool_8)
			{
				this.bool_4 = bool_8;
			}

			// Token: 0x06003E17 RID: 15895 RVA: 0x00020463 File Offset: 0x0001E663
			[CompilerGenerated]
			public void method_7(PublishedFileId_t publishedFileId_t_1)
			{
				this.publishedFileId_t_0 = publishedFileId_t_1;
			}

			// Token: 0x06003E18 RID: 15896 RVA: 0x0002046C File Offset: 0x0001E66C
			[CompilerGenerated]
			public void method_8(bool bool_8)
			{
				this.bool_5 = bool_8;
			}

			// Token: 0x06003E19 RID: 15897 RVA: 0x00144984 File Offset: 0x00142B84
			[CompilerGenerated]
			public ulong method_9()
			{
				return this.ulong_0;
			}

			// Token: 0x06003E1A RID: 15898 RVA: 0x00020475 File Offset: 0x0001E675
			[CompilerGenerated]
			public void method_10(ulong ulong_3)
			{
				this.ulong_0 = ulong_3;
			}

			// Token: 0x06003E1B RID: 15899 RVA: 0x0014499C File Offset: 0x00142B9C
			[CompilerGenerated]
			public ulong method_11()
			{
				return this.ulong_1;
			}

			// Token: 0x06003E1C RID: 15900 RVA: 0x0002047E File Offset: 0x0001E67E
			[CompilerGenerated]
			public void method_12(ulong ulong_3)
			{
				this.ulong_1 = ulong_3;
			}

			// Token: 0x06003E1D RID: 15901 RVA: 0x00020487 File Offset: 0x0001E687
			[CompilerGenerated]
			public bool method_13()
			{
				return this.bool_6;
			}

			// Token: 0x06003E1E RID: 15902 RVA: 0x0002048F File Offset: 0x0001E68F
			[CompilerGenerated]
			public void method_14(bool bool_8)
			{
				this.bool_6 = bool_8;
			}

			// Token: 0x06003E1F RID: 15903 RVA: 0x001449B4 File Offset: 0x00142BB4
			[CompilerGenerated]
			public ulong method_15()
			{
				return this.ulong_2;
			}

			// Token: 0x06003E20 RID: 15904 RVA: 0x00020498 File Offset: 0x0001E698
			[CompilerGenerated]
			public void method_16(ulong ulong_3)
			{
				this.ulong_2 = ulong_3;
			}

			// Token: 0x06003E21 RID: 15905 RVA: 0x001449CC File Offset: 0x00142BCC
			[CompilerGenerated]
			public string method_17()
			{
				return this.string_0;
			}

			// Token: 0x06003E22 RID: 15906 RVA: 0x000204A1 File Offset: 0x0001E6A1
			[CompilerGenerated]
			public void method_18(string string_1)
			{
				this.string_0 = string_1;
			}

			// Token: 0x06003E23 RID: 15907 RVA: 0x001449E4 File Offset: 0x00142BE4
			[CompilerGenerated]
			public uint method_19()
			{
				return this.uint_0;
			}

			// Token: 0x06003E24 RID: 15908 RVA: 0x000204AA File Offset: 0x0001E6AA
			[CompilerGenerated]
			public void method_20(uint uint_1)
			{
				this.uint_0 = uint_1;
			}

			// Token: 0x06003E25 RID: 15909 RVA: 0x000204B3 File Offset: 0x0001E6B3
			[CompilerGenerated]
			public void method_21(bool bool_8)
			{
				this.bool_7 = bool_8;
			}

			// Token: 0x06003E26 RID: 15910 RVA: 0x001449FC File Offset: 0x00142BFC
			public Class2503(PublishedFileId_t publishedFileId_t_1)
			{
				this.method_7(publishedFileId_t_1);
				uint itemState = SteamUGC.GetItemState(publishedFileId_t_1);
				this.method_0(((ulong)itemState & 1uL) > 0uL);
				this.method_2(((ulong)itemState & 4uL) > 0uL);
				this.method_4(((ulong)itemState & 8uL) > 0uL);
				this.method_5(((ulong)itemState & 16uL) > 0uL);
				this.method_6(((ulong)itemState & 32uL) > 0uL);
				ulong ulong_ = this.method_9();
				ulong ulong_2 = this.method_11();
				bool itemDownloadInfo = SteamUGC.GetItemDownloadInfo(publishedFileId_t_1, out ulong_, out ulong_2);
				this.method_12(ulong_2);
				this.method_10(ulong_);
				this.method_8(itemDownloadInfo);
				this.method_14(true);
				if ((this.method_3() | !this.method_1()) && SteamUGC.DownloadItem(publishedFileId_t_1, false))
				{
					this.method_14(false);
				}
				if (this.method_13())
				{
					ulong_2 = this.method_15();
					string string_ = this.method_17();
					uint uint_ = this.method_19();
					bool itemInstallInfo = SteamUGC.GetItemInstallInfo(publishedFileId_t_1, out ulong_2, out string_, 1024u, out uint_);
					this.method_20(uint_);
					this.method_18(string_);
					this.method_16(ulong_2);
					this.method_21(itemInstallInfo);
				}
			}

			// Token: 0x06003E27 RID: 15911 RVA: 0x00144B68 File Offset: 0x00142D68
			public void method_22()
			{
				if (this.method_1())
				{
					try
					{
						if (Directory.Exists(this.method_17()))
						{
							this.method_23(this.method_17(), Client.strSteamWorkshopScenarioDir, true);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}

			// Token: 0x06003E28 RID: 15912 RVA: 0x00144BC4 File Offset: 0x00142DC4
			public void method_23(string string_1, string string_2, bool bool_8)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				if (!directoryInfo.Exists)
				{
					throw new DirectoryNotFoundException(Convert.ToString("Source directory does not exist or could not be found: ") + string_1);
				}
				if (!Directory.Exists(string_2))
				{
					Directory.CreateDirectory(string_2);
				}
				FileInfo[] files = directoryInfo.GetFiles();
				int i = 0;
				checked
				{
					while (i < files.Length)
					{
						FileInfo fileInfo = files[i];
						string text = Path.Combine(string_2, fileInfo.Name);
						if (!File.Exists(text))
						{
							i++;
						}
						else
						{
							FileInfo fileInfo2 = CommandFactory.GetComputer().FileSystem.GetFileInfo(text);
							FileInfo fileInfo3 = CommandFactory.GetComputer().FileSystem.GetFileInfo(fileInfo.Name);
							if (!(DateTime.Compare(fileInfo2.CreationTimeUtc, fileInfo3.CreationTimeUtc) == 0 & fileInfo2.Length == fileInfo3.Length))
							{
								i++;
							}
							else
							{
								fileInfo.CopyTo(text, true);
								i++;
							}
						}
					}
					if (bool_8)
					{
						DirectoryInfo[] array = directories;
						for (int j = 0; j < array.Length; j++)
						{
							DirectoryInfo directoryInfo2 = array[j];
							string string_3 = Path.Combine(string_2, directoryInfo2.Name);
							this.method_23(directoryInfo2.FullName, string_3, bool_8);
						}
					}
				}
			}

			// Token: 0x04001C80 RID: 7296
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x04001C81 RID: 7297
			[CompilerGenerated]
			private bool bool_1;

			// Token: 0x04001C82 RID: 7298
			[CompilerGenerated]
			private bool bool_2 = false;

			// Token: 0x04001C83 RID: 7299
			[CompilerGenerated]
			private bool bool_3;

			// Token: 0x04001C84 RID: 7300
			[CompilerGenerated]
			private bool bool_4;

			// Token: 0x04001C85 RID: 7301
			[CompilerGenerated]
			private PublishedFileId_t publishedFileId_t_0;

			// Token: 0x04001C86 RID: 7302
			[CompilerGenerated]
			private bool bool_5;

			// Token: 0x04001C87 RID: 7303
			[CompilerGenerated]
			private ulong ulong_0;

			// Token: 0x04001C88 RID: 7304
			[CompilerGenerated]
			private ulong ulong_1;

			// Token: 0x04001C89 RID: 7305
			[CompilerGenerated]
			private bool bool_6;

			// Token: 0x04001C8A RID: 7306
			[CompilerGenerated]
			private ulong ulong_2;

			// Token: 0x04001C8B RID: 7307
			[CompilerGenerated]
			private string string_0;

			// Token: 0x04001C8C RID: 7308
			[CompilerGenerated]
			private uint uint_0;

			// Token: 0x04001C8D RID: 7309
			[CompilerGenerated]
			private bool bool_7;
		}

		// Token: 0x02000994 RID: 2452
		public sealed class Class2504
		{
			// Token: 0x04001C8E RID: 7310
			public string string_0;

			// Token: 0x04001C8F RID: 7311
			public string string_1;

			// Token: 0x04001C90 RID: 7312
			public List<string> list_0;

			// Token: 0x04001C91 RID: 7313
			public string string_2 = "";

			// Token: 0x04001C92 RID: 7314
			public string string_3 = "";

			// Token: 0x04001C93 RID: 7315
			public string string_4 = "";
		}

		// Token: 0x02000995 RID: 2453
		[CompilerGenerated]
		public sealed class Class2505
		{
			// Token: 0x06003E2A RID: 15914 RVA: 0x000204E5 File Offset: 0x0001E6E5
			public Class2505(SteamWorkshop.Class2505 class2505_0)
			{
				if (class2505_0 != null)
				{
					this.steamUGCDetails_t_0 = class2505_0.steamUGCDetails_t_0;
				}
			}

			// Token: 0x06003E2B RID: 15915 RVA: 0x000204FF File Offset: 0x0001E6FF
			internal bool method_0(SteamUGCDetails_t steamUGCDetails_t_1)
			{
				return steamUGCDetails_t_1.m_nPublishedFileId.m_PublishedFileId == this.steamUGCDetails_t_0.m_nPublishedFileId.m_PublishedFileId;
			}

			// Token: 0x04001C94 RID: 7316
			public SteamUGCDetails_t steamUGCDetails_t_0;
		}
	}
}

using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns3
{
	// Token: 0x02000BCB RID: 3019
	public sealed class Class260
	{
		// Token: 0x06006421 RID: 25633 RVA: 0x0002BED5 File Offset: 0x0002A0D5
		public static void smethod_0(Scenario scenario_0)
		{
			if (!Information.IsNothing(scenario_0))
			{
				scenario_0.ThreadedOpsMustStop = true;
				Class260.concurrentDictionary_0.TryRemove(scenario_0.GetObjectID(), out scenario_0);
				GameGeneral.ForceGarbageCollection();
			}
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x00317CDC File Offset: 0x00315EDC
		public static Scenario smethod_1(string string_0)
		{
			Scenario result = null;
			try
			{
				Scenario scenario = null;
				Misc.smethod_10(scenario);
				if (scenario.GetScenAttachments().Count > 0)
				{
					ScenarioCompressor.smethod_1(scenario, string_0);
				}
				result = scenario;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101086", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x00317D64 File Offset: 0x00315F64
		public static void SaveTempScenarioFile(Scenario theScen, Side theCurrentSide, string thePath, bool SBR, bool MarkAsCampaignCheckpoint = false)
		{
			try
			{
				if (theScen.GetSides().Count<Side>() != 0)
				{
					theScen.GameVersion = GameGeneral.strVersion;
					if (!SBR && Information.IsNothing(theCurrentSide))
					{
						theScen.ChangeSide(theScen.GetSides()[0]);
					}
					ScenContainer scenContainer = new ScenContainer(theScen);
					scenContainer.ScenTitle = theScen.GetScenarioTitle();
					scenContainer.ScenDescription = theScen.GetDescription();
					scenContainer.Complexity = theScen.Meta_Complexity;
					scenContainer.Difficulty = theScen.Meta_Difficulty;
					scenContainer.ScenSetting = theScen.Meta_ScenSetting;
					scenContainer.ScenDate = (short)theScen.GetStartTime().Year;
					if (MarkAsCampaignCheckpoint)
					{
						scenContainer.IsCampaignCheckpoint = true;
					}
					scenContainer.SaveTempScenarioFile(thePath);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101087", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x04003664 RID: 13924
		public static ConcurrentDictionary<string, Scenario> concurrentDictionary_0 = new ConcurrentDictionary<string, Scenario>();
	}
}

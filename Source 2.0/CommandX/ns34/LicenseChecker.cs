using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns32;
using ns35;
using Steamworks;

namespace ns34
{
	// Token: 0x02000AEB RID: 2795
	public sealed class LicenseChecker
	{
		// Token: 0x06005A3C RID: 23100 RVA: 0x002813F4 File Offset: 0x0027F5F4
		public static void smethod_0(bool bool_0)
		{
			try
			{
				LicenseChecker.smethod_4(bool_0);
				LicenseChecker.smethod_5(bool_0);
				LicenseChecker.smethod_6(bool_0);
				LicenseChecker.smethod_7(bool_0);
				LicenseChecker.smethod_8(bool_0);
				LicenseChecker.smethod_9(bool_0);
				LicenseChecker.smethod_10(bool_0);
				LicenseChecker.smethod_11(bool_0);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200416", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x0002891C File Offset: 0x00026B1C
		public static void AddLicense(LicenseChecker.License item)
		{
			LicenseChecker.LicenseSet.Add(item);
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x0002892A File Offset: 0x00026B2A
		public static void RemoveLicense(LicenseChecker.License item)
		{
			LicenseChecker.LicenseSet.Remove(item);
		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x00028938 File Offset: 0x00026B38
		public static bool HoldLicense(LicenseChecker.License enum189_0)
		{
			return LicenseChecker.LicenseSet.Contains(enum189_0);
		}

		// Token: 0x06005A40 RID: 23104 RVA: 0x00028945 File Offset: 0x00026B45
		private static void smethod_4(bool bool_0)
		{
			LicenseChecker.LicenseSet.Add(LicenseChecker.License.CMANOBase);
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x00028953 File Offset: 0x00026B53
		private static void smethod_5(bool bool_0)
		{
			LicenseChecker.LicenseSet.Add(LicenseChecker.License.NorthernInferno);
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x00028961 File Offset: 0x00026B61
		private static void smethod_6(bool bool_0)
		{
			LicenseChecker.LicenseSet.Add(LicenseChecker.License.ChainsOfWar);
		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x0002896F File Offset: 0x00026B6F
		private static void smethod_7(bool bool_0)
		{
			LicenseChecker.LicenseSet.Add(LicenseChecker.License.CLIVE1);
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x0002897D File Offset: 0x00026B7D
		private static void smethod_8(bool bool_0)
		{
			LicenseChecker.LicenseSet.Add(LicenseChecker.License.CLIVE2);
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x0002898B File Offset: 0x00026B8B
		private static void smethod_9(bool bool_0)
		{
			LicenseChecker.LicenseSet.Add(LicenseChecker.License.CLIVE3);
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x00028999 File Offset: 0x00026B99
		private static void smethod_10(bool bool_0)
		{
			LicenseChecker.LicenseSet.Add(LicenseChecker.License.CLIVE4);
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x000289A7 File Offset: 0x00026BA7
		private static void smethod_11(bool bool_0)
		{
			LicenseChecker.LicenseSet.Add(LicenseChecker.License.CLIVE5);
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x0000945D File Offset: 0x0000765D
		private static bool smethod_12()
		{
			return true;
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x0000945D File Offset: 0x0000765D
		private static bool smethod_13()
		{
			return true;
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x0000945D File Offset: 0x0000765D
		private static bool smethod_14()
		{
			return true;
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x0000945D File Offset: 0x0000765D
		private static bool smethod_15()
		{
			return true;
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x0000945D File Offset: 0x0000765D
		private static bool smethod_16()
		{
			return true;
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x0000945D File Offset: 0x0000765D
		private static bool smethod_17()
		{
			return true;
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x0000945D File Offset: 0x0000765D
		private static bool smethod_18()
		{
			return true;
		}

		// Token: 0x06005A4F RID: 23119 RVA: 0x0000945D File Offset: 0x0000765D
		private static bool smethod_19()
		{
			return true;
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x0028147C File Offset: 0x0027F67C
		public static bool smethod_20(string string_0)
		{
			bool flag;
			bool result;
			if (GameGeneral.bProfessionEdition)
			{
				flag = true;
			}
			else
			{
				uint num = Class2541.smethod_0(string_0);
				if (num <= 2166136261u)
				{
					if (num <= 1400166703u)
					{
						if (num != 840819822u)
						{
							if (num == 1400166703u && Operators.CompareString(string_0, "TUTORIAL", false) == 0)
							{
								result = (LicenseChecker.LicenseSet.Count > 0);
								return result;
							}
						}
						else if (Operators.CompareString(string_0, "DON", false) == 0)
						{
							result = (LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase) && LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE4));
							return result;
						}
					}
					else if (num != 1947498037u)
					{
						if (num == 2166136261u && Operators.CompareString(string_0, "", false) == 0)
						{
							result = LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase);
							return result;
						}
					}
					else if (Operators.CompareString(string_0, "BREXIT", false) == 0)
					{
						result = (LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase) && LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE2));
						return result;
					}
				}
				else if (num <= 2651058615u)
				{
					if (num != 2617503377u)
					{
						if (num == 2651058615u && Operators.CompareString(string_0, "CLIVE5", false) == 0)
						{
							result = (LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase) && LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE5));
							return result;
						}
					}
					else if (Operators.CompareString(string_0, "CLIVE3", false) == 0)
					{
						result = (LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase) && LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE3));
						return result;
					}
				}
				else if (num != 2785588663u)
				{
					if (num != 3459788944u && num == 4228905576u && Operators.CompareString(string_0, "CHAINSOFWAR", false) == 0)
					{
						result = LicenseChecker.HoldLicense(LicenseChecker.License.ChainsOfWar);
						return result;
					}
					if (num == 3459788944u && Operators.CompareString(string_0, "NINFERNO", false) == 0)
					{
						result = LicenseChecker.HoldLicense(LicenseChecker.License.NorthernInferno);
						return result;
					}
				}
				else if (Operators.CompareString(string_0, "OLDGRUDGES", false) == 0)
				{
					result = (LicenseChecker.HoldLicense(LicenseChecker.License.CMANOBase) && LicenseChecker.HoldLicense(LicenseChecker.License.CLIVE1));
					return result;
				}
				flag = false;
			}
			result = flag;
			return result;
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x002816C0 File Offset: 0x0027F8C0
		public static bool IsFeatureSupported(Scenario.ScenarioFeatureOption scenarioFeatureOption)
		{
			bool result;
			switch (scenarioFeatureOption)
			{
			case Scenario.ScenarioFeatureOption.DetailedGunFireControl:
				result = true;
				break;
			case Scenario.ScenarioFeatureOption.Realism_UnlimitedBaseMags:
				result = true;
				break;
			case Scenario.ScenarioFeatureOption.AircraftDamageModel:
				result = LicenseChecker.HoldLicense(LicenseChecker.License.ChainsOfWar);
				break;
			case Scenario.ScenarioFeatureOption.CargoOps:
				result = LicenseChecker.HoldLicense(LicenseChecker.License.ChainsOfWar);
				break;
			case Scenario.ScenarioFeatureOption.CommsJamming:
				result = GameGeneral.bProfessionEdition;
				break;
			case Scenario.ScenarioFeatureOption.CommsDisruption:
				result = LicenseChecker.HoldLicense(LicenseChecker.License.ChainsOfWar);
				break;
			case Scenario.ScenarioFeatureOption.EMP_Omni:
				result = LicenseChecker.HoldLicense(LicenseChecker.License.ChainsOfWar);
				break;
			case Scenario.ScenarioFeatureOption.EMP_Dir:
			case Scenario.ScenarioFeatureOption.HGV:
				result = GameGeneral.bProfessionEdition;
				break;
			case Scenario.ScenarioFeatureOption.HighEnergyLasers:
				result = LicenseChecker.HoldLicense(LicenseChecker.License.ChainsOfWar);
				break;
			case Scenario.ScenarioFeatureOption.RailgunOrHVP:
				result = LicenseChecker.HoldLicense(LicenseChecker.License.ChainsOfWar);
				break;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x00004BC2 File Offset: 0x00002DC2
		internal static void smethod_22()
		{
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x00281764 File Offset: 0x0027F964
		private static void smethod_23()
		{
			string path = Path.Combine(CommandFactory.GetCommandApp().Info.DirectoryPath, "CommandX.ini");
			if (File.Exists(path) && DateTime.Compare(File.GetLastWriteTime(path).ToUniversalTime(), DateTime.UtcNow) > 0)
			{
				Interaction.MsgBox("Your license period has expired. Please contact the software provider to obtain a valid license. The program will now exit", MsgBoxStyle.OkOnly, null);
				Environment.Exit(0);
			}
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x002817CC File Offset: 0x0027F9CC
		private static void smethod_24()
		{
			EventLog eventLog = new EventLog("system");
			IEnumerator enumerator = eventLog.Entries.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (DateTime.Compare(((EventLogEntry)enumerator.Current).TimeWritten.ToUniversalTime(), DateTime.UtcNow) > 0)
					{
						Interaction.MsgBox("Your license period has expired. Please contact the software provider to obtain a valid license. The program will now exit", MsgBoxStyle.OkOnly, null);
						Environment.Exit(0);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x04002CCB RID: 11467
		public static float float_0 = 1.001f;

		// Token: 0x04002CCC RID: 11468
		public static AppId_t appId_t_0 = new AppId_t(321410u);

		// Token: 0x04002CCD RID: 11469
		public static AppId_t appId_t_1 = new AppId_t(397180u);

		// Token: 0x04002CCE RID: 11470
		public static AppId_t appId_t_2N = new AppId_t(614130u);

		// Token: 0x04002CCF RID: 11471
		public static AppId_t appId_t_2 = new AppId_t(388020u);

		// Token: 0x04002CD0 RID: 11472
		public static AppId_t appId_t_3 = new AppId_t(497611u);

		// Token: 0x04002CD1 RID: 11473
		public static AppId_t appId_t_4 = new AppId_t(527370u);

		// Token: 0x04002CD2 RID: 11474
		public static AppId_t appId_t_5 = new AppId_t(497610u);

		// Token: 0x04002CD3 RID: 11475
		public static AppId_t appId_t_6 = new AppId_t(584260u);

		// Token: 0x04002CD4 RID: 11476
		private static HashSet<LicenseChecker.License> LicenseSet = new HashSet<LicenseChecker.License>();

		// Token: 0x02000AEC RID: 2796
		public enum License
		{
			// Token: 0x04002CD6 RID: 11478
			CMANOBase,
			// Token: 0x04002CD7 RID: 11479
			NorthernInferno,
			// Token: 0x04002CD8 RID: 11480
			CLIVE1,
			// Token: 0x04002CD9 RID: 11481
			CLIVE2,
			// Token: 0x04002CDA RID: 11482
			CLIVE3,
			// Token: 0x04002CDB RID: 11483
			CLIVE4,
			// Token: 0x04002CDC RID: 11484
			CLIVE5,
			// Token: 0x04002CDD RID: 11485
			ChainsOfWar,
			// Token: 0x04002CDE RID: 11486
			ProfessionalEdition
		}
	}
}

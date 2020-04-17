using System;
using System.Diagnostics;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace ns35
{
	// Token: 0x02000A76 RID: 2678
	public sealed class Class2531
	{
		// Token: 0x060054DD RID: 21725 RVA: 0x00235014 File Offset: 0x00233214
		public static void smethod_0()
		{
			try
			{
				Class2531.class2530_0 = new Class2530();
				Class2531.soundHandler_Effects_0 = new SoundHandler_Effects();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200419", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				Class2531.smethod_2(ex2);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x0023508C File Offset: 0x0023328C
		public static void smethod_1()
		{
			try
			{
				Class2531.class2530_0.method_0();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200420", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				Class2531.smethod_2(ex2);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x000270AC File Offset: 0x000252AC
		public static void smethod_2(Exception exception_0)
		{
			Interaction.MsgBox("There has been a serious error with sound. The error description is: " + exception_0.Message + " . Sound effects and music will now be disabled. Please contact the Command development team with this information to help them troubleshoot this issue.", MsgBoxStyle.Critical, "Critical sound problem");
			SimConfiguration.gameOptions.SetGameSoundsON(false);
			SimConfiguration.gameOptions.SetGameMusicON(false);
			SimConfiguration.SaveConfig();
		}

		// Token: 0x04002903 RID: 10499
		public static Class2530 class2530_0;

		// Token: 0x04002904 RID: 10500
		public static SoundHandler_Effects soundHandler_Effects_0;
	}
}

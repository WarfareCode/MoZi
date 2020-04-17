using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Command_Core;
using ns3;
using SevenZip;

namespace ns0
{
	// Token: 0x02000A17 RID: 2583
	public sealed class ScenarioCompressor
	{
		// Token: 0x06005068 RID: 20584 RVA: 0x0020B66C File Offset: 0x0020986C
		public static void smethod_0(Scenario scenario_0, Side side_0, string string_0)
		{
			if (scenario_0.GetScenAttachments().Count != 0)
			{
				if (Directory.Exists(Path.Combine(GameGeneral.strTempDir, "package")))
				{
					Directory.Delete(Path.Combine(GameGeneral.strTempDir, "package"), true);
				}
				Directory.CreateDirectory(Path.Combine(GameGeneral.strTempDir, "package"));
				Class260.SaveTempScenarioFile(scenario_0, side_0, Path.Combine(GameGeneral.strTempDir, "package", Path.GetFileNameWithoutExtension(string_0) + ".scen"), false, false);
				Directory.CreateDirectory(Path.Combine(GameGeneral.strTempDir, "package\\attachments"));
				foreach (KeyValuePair<string, ScenAttachmentObject> current in scenario_0.GetScenAttachments())
				{
					if (Directory.Exists(Path.Combine(GameGeneral.strAttachmentRepoDir, current.Key)))
					{
						Misc.smethod_2(Path.Combine(GameGeneral.strAttachmentRepoDir, current.Key), Path.Combine(GameGeneral.strTempDir, "package\\attachments", current.Key), true);
					}
				}
				ScenarioCompressor.sevenZipCompressor_0 = new SevenZipCompressor();
				ScenarioCompressor.sevenZipCompressor_0.ArchiveFormat = OutArchiveFormat.Zip;
				ScenarioCompressor.sevenZipCompressor_0.CompressionLevel = CompressionLevel.Fast;
				ScenarioCompressor.sevenZipCompressor_0.CompressDirectory(Path.Combine(GameGeneral.strTempDir, "package"), string_0, true);
				Directory.Delete(Path.Combine(GameGeneral.strTempDir, "package"), true);
				ScenarioCompressor.sevenZipCompressor_0 = null;
			}
		}

		// Token: 0x06005069 RID: 20585 RVA: 0x0020B7E8 File Offset: 0x002099E8
		public static void smethod_1(Scenario scenario_0, string string_0)
		{
			string text = Path.Combine(Path.GetDirectoryName(string_0), "attachments");
			if (Directory.Exists(text))
			{
				foreach (KeyValuePair<string, ScenAttachmentObject> current in scenario_0.GetScenAttachments())
				{
					if (Directory.Exists(Path.Combine(text, current.Key)))
					{
						if (Directory.Exists(Path.Combine(GameGeneral.strAttachmentRepoDir, current.Key)))
						{
							Directory.Delete(Path.Combine(GameGeneral.strAttachmentRepoDir, current.Key), true);
						}
						Directory.Move(Path.Combine(text, current.Key), Path.Combine(GameGeneral.strAttachmentRepoDir, current.Key));
					}
				}
				if (Directory.Exists(text) && Directory.EnumerateFileSystemEntries(text).Count<string>() == 0)
				{
					Directory.Delete(text);
				}
			}
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x0020B8E4 File Offset: 0x00209AE4
		public static void smethod_2(string string_0)
		{
			string text = Path.Combine(string_0, "attachments");
			checked
			{
				if (Directory.Exists(text))
				{
					string[] directories = Directory.GetDirectories(text);
					for (int i = 0; i < directories.Length; i++)
					{
						string path = directories[i];
						if (Directory.Exists(Path.Combine(GameGeneral.strAttachmentRepoDir, Path.GetFileName(path))))
						{
							Directory.Delete(Path.Combine(GameGeneral.strAttachmentRepoDir, Path.GetFileName(path)), true);
						}
						Directory.Move(Path.Combine(text, Path.GetFileName(path)), Path.Combine(GameGeneral.strAttachmentRepoDir, Path.GetFileName(path)));
					}
					if (Directory.Exists(text) && Directory.EnumerateFileSystemEntries(text).Count<string>() == 0)
					{
						Directory.Delete(text);
					}
				}
			}
		}

		// Token: 0x040025CF RID: 9679
		private static SevenZipCompressor sevenZipCompressor_0;
	}
}

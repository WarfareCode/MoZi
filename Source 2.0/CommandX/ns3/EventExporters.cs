using System;
using System.Collections.Generic;
using System.IO;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns29;

namespace ns3
{
	// Token: 0x02000BC0 RID: 3008
	public sealed class EventExporters
	{
		// Token: 0x060063CA RID: 25546 RVA: 0x00315B4C File Offset: 0x00313D4C
		public static void Init()
		{
			if (File.Exists(EventExporters.strIniFile))
			{
				string left = new Class2372(EventExporters.strIniFile).GetConfigList()["General"].GetValue("ActiveExporter").ToString();
				if (Operators.CompareString(left, "CSV", false) == 0)
				{
					EventExporters.listRegular.Add(new EventExport_CSV(_RunMode.Normal));
				}
				else if (Operators.CompareString(left, "Tacview1x", false) == 0)
				{
					EventExporters.listRegular.Add(new EventExport_Tacview1x(_RunMode.Normal, MyTemplate.GetApp().Info.DirectoryPath));
				}
				else if (Operators.CompareString(left, "Tacview2x", false) == 0)
				{
					EventExporters.listRegular.Add(new EventExport_Tacview2x(_RunMode.Normal, MyTemplate.GetApp().Info.DirectoryPath));
				}
				else if (Operators.CompareString(left, "XML", false) == 0)
				{
					EventExporters.listRegular.Add(new EventExport_XMLFile(_RunMode.Normal));
				}
				else if (Operators.CompareString(left, "MSAccess", false) == 0)
				{
					EventExporters.listRegular.Add(new EventExport_MSAccess(_RunMode.Normal));
				}
			}
		}

		// Token: 0x0400362D RID: 13869
		public static List<IEventExporter> listRegular = new List<IEventExporter>();

		// Token: 0x0400362E RID: 13870
		public static List<IEventExporter> listMonteCarlo = new List<IEventExporter>();

		// Token: 0x0400362F RID: 13871
		public static string strIniFile = MyTemplate.GetApp().Info.DirectoryPath + "\\EventExport.ini";
	}
}

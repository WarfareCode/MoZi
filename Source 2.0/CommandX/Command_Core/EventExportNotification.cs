using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x02000BC3 RID: 3011
	[Serializable]
	public sealed class EventExportNotification
	{
		// Token: 0x060063CD RID: 25549 RVA: 0x00315C70 File Offset: 0x00313E70
		public byte[] GetExportData()
		{
			byte[] result;
			if (this == null)
			{
				result = null;
			}
			else
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				MemoryStream memoryStream = new MemoryStream();
				binaryFormatter.Serialize(memoryStream, this);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x00315CA8 File Offset: 0x00313EA8
		public static EventExportNotification smethod_0(byte[] byte_0)
		{
			EventExportNotification result;
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				memoryStream.Write(byte_0, 0, byte_0.Length);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				result = (EventExportNotification)binaryFormatter.Deserialize(memoryStream);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04003640 RID: 13888
		public ExportedEventType EventType;

		// Token: 0x04003641 RID: 13889
		public Dictionary<string, Tuple<Type, string>> EventParameters;

		// Token: 0x04003642 RID: 13890
		public string FileExportFolder;

		// Token: 0x04003643 RID: 13891
		public Scenario ParentScen;
	}
}

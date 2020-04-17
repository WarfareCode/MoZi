using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using ns0;

namespace ns4
{
	// Token: 0x02000C11 RID: 3089
	public sealed class GISElevations
	{
		// Token: 0x060066E3 RID: 26339 RVA: 0x0035A0F4 File Offset: 0x003582F4
		public GISElevations()
		{
			this.ElevationData = new short[3601, 7201];
			if (!Directory.Exists(Application.StartupPath + "\\GIS\\"))
			{
				Interaction.MsgBox("Could not find the map data directory " + Application.StartupPath + "\\GIS\\. Is the simulator installed correctly?", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				using (FileStream fileStream = new FileStream(MyTemplate.GetApp().Info.DirectoryPath + "\\GIS\\Elevations", FileMode.Open))
				{
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					this.ElevationData = (short[,])binaryFormatter.Deserialize(fileStream);
				}
			}
		}

		// Token: 0x060066E4 RID: 26340 RVA: 0x0035A1A8 File Offset: 0x003583A8
		public short GetElevation(float Latitude_, float Longitude_)
		{
			short num = (short)Math.Round((double)(Latitude_ + 90f) / 0.05);
			short num2 = (short)Math.Round((double)(Longitude_ + 180f) / 0.05);
			short num3 = this.ElevationData[(int)num, (int)num2];
			if (num3 == 0)
			{
				short elevation = Terrain.GetElevation((double)Latitude_, (double)Longitude_, false);
				this.ElevationData[(int)num, (int)num2] = elevation;
				num3 = elevation;
			}
			return num3;
		}

		// Token: 0x04003897 RID: 14487
		private short[,] ElevationData;
	}
}

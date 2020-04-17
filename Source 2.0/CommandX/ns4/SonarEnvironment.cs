using System;
using System.Diagnostics;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4
{
	// Token: 0x02000CA9 RID: 3241
	public sealed class SonarEnvironment
	{
		// Token: 0x06006B1F RID: 27423 RVA: 0x003A3884 File Offset: 0x003A1A84
		public static float GetConvergenceZoneIncrement(double Latitude)
		{
			return (float)(20.0 + 20.0 * ((Math.Abs(Latitude) + 1E-07) / 90.0));
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x003A38C4 File Offset: 0x003A1AC4
		public static void SetLayerData(double Latitude_, double Longitude_, int TerrainElevation_, ref int LayerCeiling, ref int LayerBottom, ref float LayerStrength, bool bool_0)
		{
			SonarEnvironment.Thermocline layer = SonarEnvironment.GetLayer(Latitude_, Longitude_, TerrainElevation_);
			LayerCeiling = layer.Ceiling;
			LayerBottom = layer.Bottom;
			LayerStrength = layer.Strength;
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x003A38F4 File Offset: 0x003A1AF4
		public static SonarEnvironment.Thermocline GetLayer(double Latitude_, double Longitude_, int TerrainElevation_)
		{
			SonarEnvironment.Thermocline result = null;
			try
			{
				SonarEnvironment.Thermocline thermocline = new SonarEnvironment.Thermocline();
				float num = 0.7f;
				float num2 = 0.2f;
				float num3 = 1f - (float)(Math.Abs(Latitude_) / 90.0);
				thermocline.Ceiling = Math.Min(-40, (int)Math.Round((double)(-10f + num3 * -150f - -10f)));
				int num4 = (int)Math.Round((double)(10f + num3 * 90f));
				thermocline.Bottom = thermocline.Ceiling - num4;
				short elevation = Terrain.GetElevation(Latitude_, Longitude_, false);
				if ((int)elevation > thermocline.Bottom)
				{
					thermocline.Ceiling = (int)Math.Round((double)thermocline.Ceiling * ((double)Math.Abs(elevation) / 250.0));
					num4 = (int)Math.Round((double)num4 * ((double)Math.Abs(elevation) / 250.0));
					thermocline.Bottom = (int)Math.Round((double)thermocline.Bottom * ((double)Math.Abs(elevation) / 250.0));
				}
				thermocline.Strength = num2 + num3 * (num - num2);
				result = thermocline;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101125", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x003A3A74 File Offset: 0x003A1C74
		public static SonarEnvironment._SonobuoyDepthSetting GetSonobuoyDepthSetting(float Altitude_ASL_, SonarEnvironment.Thermocline theThermocline)
		{
			SonarEnvironment._SonobuoyDepthSetting result;
			if (Altitude_ASL_ > -10f)
			{
				result = SonarEnvironment._SonobuoyDepthSetting.Shallow;
			}
			else if (Altitude_ASL_ > (float)theThermocline.Ceiling)
			{
				result = SonarEnvironment._SonobuoyDepthSetting.Shallow;
			}
			else if (Altitude_ASL_ < (float)theThermocline.Bottom)
			{
				result = SonarEnvironment._SonobuoyDepthSetting.Deep;
			}
			else
			{
				result = SonarEnvironment._SonobuoyDepthSetting.Intermediate;
			}
			return result;
		}

		// Token: 0x02000CAA RID: 3242
		public enum _SonobuoyDepthSetting : byte
		{
			// Token: 0x04003CF1 RID: 15601
			Shallow,
			// Token: 0x04003CF2 RID: 15602
			Intermediate,
			// Token: 0x04003CF3 RID: 15603
			Deep
		}

		// Token: 0x02000CAB RID: 3243
		public sealed class Thermocline
		{
			// Token: 0x06006B24 RID: 27428 RVA: 0x0002DF6E File Offset: 0x0002C16E
			public bool method_0(float float_1)
			{
				return float_1 - (float)this.Bottom < 70f;
			}

			// Token: 0x04003CF4 RID: 15604
			public int Ceiling;

			// Token: 0x04003CF5 RID: 15605
			public int Bottom;

			// Token: 0x04003CF6 RID: 15606
			public float Strength;
		}
	}
}

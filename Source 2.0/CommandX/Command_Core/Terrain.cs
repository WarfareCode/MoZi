using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using ns0;
using ns18;
using ns19;
using ns3;
using ns4;

namespace Command_Core
{
	// Token: 地形
	public sealed class Terrain
	{
		// 载入地形网格
		public static void LoadTerrainGrids()
		{
			checked
			{
				try
				{
					Terrain.string_0 = MyTemplate.GetApp().Info.DirectoryPath + "\\GIS\\Terrain\\SRTM30Plus\\";
					string[] directories = Directory.GetDirectories(Terrain.string_0);
					for (int i = 0; i < directories.Length; i++)
					{
						string directory = directories[i];
						MyTemplate.GetComputer().FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
					}
					Terrain.dictionary_0.Clear();
					Terrain.int_1 = Directory.GetFiles(Terrain.string_0).Count<string>();
					int num = 0;
					string[] files = Directory.GetFiles(Terrain.string_0);
					for (int j = 0; j < files.Length; j++)
					{
						string text = files[j];
						unchecked
						{
							if (text.EndsWith(".bgd"))
							{
								num++;
								Terrain.class373_0 = new Class372.Class373();
								Terrain.class373_0.method_4(text);
								Terrain.class373_0.string_0 = Path.GetFileName(text);
								List<Class372.Class373> list = new List<Class372.Class373>();
								list.Add(Terrain.class373_0);
								Terrain.dictionary_0.Add(Path.GetFileName(text), list);
								Terrain.int_0 = num;
							}
						}
					}
					Terrain.bool_0 = true;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ex2.Data.Add("Error at 101105", "");
					GameGeneral.LogException(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x003A971C File Offset: 0x003A791C
		public static void Close()
		{
			try
			{
				foreach (List<Class372.Class373> current in Terrain.dictionary_0.Values)
				{
					foreach (Class372.Class373 current2 in current)
					{
						if (!Information.IsNothing(current2))
						{
							current2.method_1();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200271", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x0002DFC3 File Offset: 0x0002C1C3
		public static void smethod_2(ref short short_0)
		{
			if (short_0 < 0 && short_0 > -20)
			{
				short_0 = -20;
			}
		}

		// Token: 0x06006B66 RID: 27494 RVA: 0x003A9800 File Offset: 0x003A7A00
		public static string smethod_3(double double_0, double double_1)
		{
			double_0 = Math2.NormalizeLatitude(double_0);
			double_1 = Math2.NormalizeLongitude(double_1);
			double num = double_0;
			string result;
			if (num > 40.0)
			{
				double num2 = double_1;
				if (num2 > 140.0)
				{
					result = "e140n90.bgd";
				}
				else if (num2 > 100.0)
				{
					result = "e100n90.bgd";
				}
				else if (num2 > 60.0)
				{
					result = "e60n90.bgd";
				}
				else if (num2 > 20.0)
				{
					result = "e20n90.bgd";
				}
				else if (num2 > -20.0)
				{
					result = "w20n90.bgd";
				}
				else if (num2 > -60.0)
				{
					result = "w60n90.bgd";
				}
				else if (num2 > -100.0)
				{
					result = "w100n90.bgd";
				}
				else if (num2 > -140.0)
				{
					result = "w140n90.bgd";
				}
				else
				{
					result = "w180n90.bgd";
				}
			}
			else if (num > -10.0)
			{
				double num3 = double_1;
				if (num3 > 140.0)
				{
					result = "e140n40.bgd";
				}
				else if (num3 > 100.0)
				{
					result = "e100n40.bgd";
				}
				else if (num3 > 60.0)
				{
					result = "e60n40.bgd";
				}
				else if (num3 > 20.0)
				{
					result = "e20n40.bgd";
				}
				else if (num3 > -20.0)
				{
					result = "w20n40.bgd";
				}
				else if (num3 > -60.0)
				{
					result = "w60n40.bgd";
				}
				else if (num3 > -100.0)
				{
					result = "w100n40.bgd";
				}
				else if (num3 > -140.0)
				{
					result = "w140n40.bgd";
				}
				else
				{
					result = "w180n40.bgd";
				}
			}
			else if (num > -60.0)
			{
				double num4 = double_1;
				if (num4 > 140.0)
				{
					result = "e140s10.bgd";
				}
				else if (num4 > 100.0)
				{
					result = "e100s10.bgd";
				}
				else if (num4 > 60.0)
				{
					result = "e60s10.bgd";
				}
				else if (num4 > 20.0)
				{
					result = "e20s10.bgd";
				}
				else if (num4 > -20.0)
				{
					result = "w20s10.bgd";
				}
				else if (num4 > -60.0)
				{
					result = "w60s10.bgd";
				}
				else if (num4 > -100.0)
				{
					result = "w100s10.bgd";
				}
				else if (num4 > -140.0)
				{
					result = "w140s10.bgd";
				}
				else
				{
					result = "w180s10.bgd";
				}
			}
			else
			{
				double num5 = double_1;
				if (num5 > 120.0)
				{
					result = "e120s60.bgd";
				}
				else if (num5 > 60.0)
				{
					result = "e60s60.bgd";
				}
				else if (num5 > 0.0)
				{
					result = "w0s60.bgd";
				}
				else if (num5 > -60.0)
				{
					result = "w60s60.bgd";
				}
				else if (num5 > -120.0)
				{
					result = "w120s60.bgd";
				}
				else
				{
					result = "w180s60.bgd";
				}
			}
			return result;
		}

		// Token: 0x06006B67 RID: 27495 RVA: 0x003A9BC4 File Offset: 0x003A7DC4
		public static short GetElevation(double double_0, double double_1, bool bool_1)
		{
			short num2;
			short result;
			try
			{
				double_0 = Math2.NormalizeLatitude(double_0);
				double_1 = Math2.NormalizeLongitude(double_1);
				string text = Terrain.smethod_3(double_0, double_1);
				List<Class372.Class373> list = Terrain.dictionary_0[text];
				int count = list.Count;
				Class372.Class373 @class = null;
				while (Information.IsNothing(@class))
				{
					int num = count - 1;
					for (int i = 0; i <= num; i++)
					{
						Class372.Class373 class2 = list[i];
						if (!Information.IsNothing(class2) && !class2.bool_0)
						{
							@class = class2;
							num2 = @class.method_2(double_1, double_0, bool_1);
							result = num2;
							return result;
						}
					}
					if (list.Count < Terrain.int_2)
					{
						Terrain.class373_0 = new Class372.Class373();
						Terrain.class373_0.method_4(Terrain.string_0 + "\\" + text);
						Terrain.class373_0.string_0 = Path.GetFileName(text);
						Terrain.class373_0.class374_0 = list[0].class374_0;
						if (list.Count < Terrain.int_2)
						{
							list.Add(Terrain.class373_0);
						}
						@class = Terrain.class373_0;
					}
				}
				num2 = @class.method_2(double_1, double_0, bool_1);
				result = num2;
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200092", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				num2 = 0;
				ProjectData.ClearProjectError();
			}
			result = num2;
			return result;
		}

		// Token: 0x06006B68 RID: 27496 RVA: 0x003A9D58 File Offset: 0x003A7F58
		public static float smethod_5(double double_0, double double_1, bool bool_1)
		{
			float result = 0f;
			try
			{
				double_0 = Math2.NormalizeLatitude(double_0);
				double_1 = Math2.NormalizeLongitude(double_1);
				GeoPoint geoPoint = GeoPoint.smethod_8(double_0, double_1, 315f, 0.12142472f);
				GeoPoint geoPoint2 = GeoPoint.smethod_8(double_0, double_1, 0f, 0.12142472f);
				GeoPoint geoPoint3 = GeoPoint.smethod_8(double_0, double_1, 45f, 0.12142472f);
				GeoPoint geoPoint4 = GeoPoint.smethod_8(double_0, double_1, 90f, 0.12142472f);
				GeoPoint geoPoint5 = GeoPoint.smethod_8(double_0, double_1, 135f, 0.12142472f);
				GeoPoint geoPoint6 = GeoPoint.smethod_8(double_0, double_1, 180f, 0.12142472f);
				GeoPoint geoPoint7 = GeoPoint.smethod_8(double_0, double_1, 225f, 0.12142472f);
				GeoPoint geoPoint8 = GeoPoint.smethod_8(double_0, double_1, 270f, 0.12142472f);
				float value = (float)((double)(Terrain.GetElevation(geoPoint2.GetLatitude(), geoPoint2.GetLongitude(), bool_1) - Terrain.GetElevation(geoPoint6.GetLatitude(), geoPoint6.GetLongitude(), bool_1)) / 450.0);
				float value2 = (float)((double)(Terrain.GetElevation(geoPoint4.GetLatitude(), geoPoint4.GetLongitude(), bool_1) - Terrain.GetElevation(geoPoint8.GetLatitude(), geoPoint8.GetLongitude(), bool_1)) / 450.0);
				float value3 = (float)((double)(Terrain.GetElevation(geoPoint3.GetLatitude(), geoPoint3.GetLongitude(), bool_1) - Terrain.GetElevation(geoPoint7.GetLatitude(), geoPoint7.GetLongitude(), bool_1)) / 450.0);
				float value4 = (float)((double)(Terrain.GetElevation(geoPoint.GetLatitude(), geoPoint.GetLongitude(), bool_1) - Terrain.GetElevation(geoPoint5.GetLatitude(), geoPoint5.GetLongitude(), bool_1)) / 450.0);
				result = new List<float>
				{
					Math.Abs(value2),
					Math.Abs(value),
					Math.Abs(value3),
					Math.Abs(value4)
				}.Max();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200094", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006B69 RID: 27497 RVA: 0x003A9F98 File Offset: 0x003A8198
		public static float smethod_6(double double_0, double double_1, float float_2)
		{
			Dictionary<string, short> dictionary = new Dictionary<string, short>();
			double_0 = Math2.NormalizeLatitude(double_0);
			double_1 = Math2.NormalizeLongitude(double_1);
			double num = 0.0;
			double num2 = 0.0;
			GeoPointGenerator.GetOtherGeoPoint(double_1, double_0, ref num, ref num2, (double)((float)((double)float_2 * 1.414)), 225.0);
			double degrees = 0.0;
			double degrees2 = 0.0;
			GeoPointGenerator.GetOtherGeoPoint(double_1, double_0, ref degrees, ref degrees2, (double)((float)((double)float_2 * 1.414)), 315.0);
			double degrees3 = 0.0;
			double degrees4 = 0.0;
			GeoPointGenerator.GetOtherGeoPoint(double_1, double_0, ref degrees3, ref degrees4, (double)((float)((double)float_2 * 1.414)), 45.0);
			double degrees5 = 0.0;
			double degrees6 = 0.0;
			GeoPointGenerator.GetOtherGeoPoint(double_1, double_0, ref degrees5, ref degrees6, (double)((float)((double)float_2 * 1.414)), 135.0);
			Angle angle = default(Angle);
			angle.SetDegrees(num);
			Angle angle2 = default(Angle);
			angle2.SetDegrees(num2);
			Angle angle3 = default(Angle);
			angle3.SetDegrees(degrees);
			Angle angle4 = default(Angle);
			angle4.SetDegrees(degrees2);
			Angle lat = default(Angle);
			lat.SetDegrees(degrees4);
			Angle lon = default(Angle);
			lon.SetDegrees(degrees3);
			Angle lon2 = default(Angle);
			lon2.SetDegrees(degrees5);
			Angle lat2 = default(Angle);
			lat2.SetDegrees(degrees6);
			Angle d = World.ApproxAngularDistance(angle2, angle, angle4, angle3);
			float num3 = 0f;
			float num4 = 0f;
			StringBuilder stringBuilder = new StringBuilder();
			while ((double)num3 < d.GetDegrees())
			{
				Angle latA = default(Angle);
				Angle lonA = default(Angle);
				Angle latB = default(Angle);
				Angle lonB = default(Angle);
				World.IntermediateGCPoint((float)((double)num3 / d.GetDegrees()), angle2, angle, angle4, angle3, d, out latA, out lonA);
				World.IntermediateGCPoint((float)((double)num3 / d.GetDegrees()), lat2, lon2, lat, lon, d, out latB, out lonB);
				Angle angle5 = World.ApproxAngularDistance(latA, lonA, latB, lonB);
				while ((double)num4 < angle5.GetDegrees())
				{
					double num5 = Math2.NormalizeLatitude(num2 + (double)num3);
					double num6 = Math2.NormalizeLongitude(num + (double)num4);
					string text = Terrain.smethod_3(num5, num6);
					Class372.Class373 @class = Terrain.dictionary_0[text][0];
					try
					{
						Tuple<int, int> tuple = @class.method_0(num6, num5);
						int item = tuple.Item1;
						int item2 = tuple.Item2;
						stringBuilder.Clear();
						stringBuilder.Append(text);
						stringBuilder.Append("_");
						stringBuilder.Append(item);
						stringBuilder.Append("_");
						stringBuilder.Append(item2);
						string key = stringBuilder.ToString();
						if (!dictionary.ContainsKey(key))
						{
							dictionary.Add(key, @class.method_2(num6, num5, false));
						}
						goto IL_339;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ex2.Data.Add("Error at 101107", "");
						GameGeneral.LogException(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						ProjectData.ClearProjectError();
						goto IL_339;
					}
					break;
					IL_339:
					num4 += Terrain.float_1;
				}
				num3 += Terrain.float_1;
			}
			return (float)((double)dictionary.Values.Where(Terrain.shortFunc).Count<short>() / (double)dictionary.Values.Count);
		}

		// Token: 0x04003D85 RID: 15749
		public static Func<short, bool> shortFunc = (short short_0) => short_0 >= 0;

		// Token: 0x04003D86 RID: 15750
		public static bool bool_0 = false;

		// Token: 0x04003D87 RID: 15751
		public static int int_0;

		// Token: 0x04003D88 RID: 15752
		public static int int_1;

		// Token: 0x04003D89 RID: 15753
		private static string string_0;

		// Token: 0x04003D8A RID: 15754
		private static Class372.Class373 class373_0;

		// Token: 0x04003D8B RID: 15755
		public static Dictionary<string, List<Class372.Class373>> dictionary_0 = new Dictionary<string, List<Class372.Class373>>();

		// Token: 0x04003D8C RID: 15756
		private static Dictionary<Class372.Class373, int> dictionary_1 = new Dictionary<Class372.Class373, int>();

		// Token: 0x04003D8D RID: 15757
		private static float float_0 = 0.5f;

		// Token: 0x04003D8E RID: 15758
		private static float float_1 = 0.008333334f;

		// Token: 0x04003D8F RID: 15759
		private static int int_2 = 30;
	}
}

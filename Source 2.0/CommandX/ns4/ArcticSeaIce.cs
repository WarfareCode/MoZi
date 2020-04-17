using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using ns0;
using ns6;

namespace ns4
{
	// Token: 0x02000BFD RID: 3069
	public sealed class ArcticSeaIce
	{
		// Token: 0x06006617 RID: 26135 RVA: 0x00350394 File Offset: 0x0034E594
		public static void smethod_0()
		{
			string[] directories = Directory.GetDirectories(MyTemplate.GetApp().Info.DirectoryPath + "\\GIS\\SeaIce\\Arctic\\");
			checked
			{
				for (int i = 0; i < directories.Length; i++)
				{
					string directory = directories[i];
					MyTemplate.GetComputer().FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
				}
				ArcticSeaIce.smethod_4(DateTime.Now);
				ArcticSeaIce.list_0 = ArcticSeaIce.smethod_5(DateTime.Now);
			}
		}

		// Token: 0x06006618 RID: 26136 RVA: 0x00350400 File Offset: 0x0034E600
		public static bool IsNearMarginalIceZone(double Longitude, double Latitude)
		{
			bool result = false;
			try
			{
				if (Latitude > 0.0)
				{
					double num = Latitude;
					double? num2 = ArcticSeaIce.nullable_0;
					if ((num2.HasValue ? new bool?(num > num2.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						result = true;
					}
					else
					{
						num = Latitude;
						num2 = ArcticSeaIce.nullable_1;
						if ((num2.HasValue ? new bool?(num < num2.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							result = false;
						}
						else
						{
							Longitude = Math2.NormalizeLongitude(Longitude);
							Latitude = Math2.NormalizeLatitude(Latitude);
							string text = Terrain.smethod_3(Latitude, Longitude);
							Tuple<int, int> tuple = Terrain.dictionary_0[text][0].method_0(Longitude, Latitude);
							int item = tuple.Item1;
							int item2 = tuple.Item2;
							string text2 = string.Concat(new string[]
							{
								Path.ChangeExtension(text, null),
								"_",
								Conversions.ToString(item),
								".",
								Conversions.ToString(item2)
							});
							bool? flag = ArcticSeaIce.class269_0.method_0(text2);
							if (Information.IsNothing(flag))
							{
								bool bool_;
								flag = new bool?(bool_ = ArcticSeaIce.smethod_2(Latitude, Longitude));
								ArcticSeaIce.class269_0.method_1(text2, bool_);
								result = flag.Value;
							}
							else
							{
								result = flag.Value;
							}
						}
					}
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101100", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x003505E4 File Offset: 0x0034E7E4
		private static bool smethod_2(double double_0, double double_1)
		{
			bool result = false;
			try
			{
				new GeoPoint(double_1, double_0);
				if (double_0 > 0.0)
				{
					double? num = ArcticSeaIce.nullable_0;
					if ((num.HasValue ? new bool?(double_0 > num.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						result = true;
					}
					else
					{
						num = ArcticSeaIce.nullable_1;
						if ((num.HasValue ? new bool?(double_0 < num.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							result = false;
						}
						else
						{
							bool flag = false;
							List<Class377>.Enumerator enumerator = ArcticSeaIce.smethod_3().GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									if (enumerator.Current.method_0(double_0, double_1, false))
									{
										flag = true;
										break;
									}
								}
							}
							finally
							{
								IDisposable disposable = enumerator;
								if (disposable != null)
								{
									disposable.Dispose();
								}
							}
							result = flag;
						}
					}
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101102", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x00350738 File Offset: 0x0034E938
		public static List<Class377> smethod_3()
		{
			if (Information.IsNothing(ArcticSeaIce.list_0))
			{
				ArcticSeaIce.list_0 = ArcticSeaIce.smethod_5(DateTime.Now);
			}
			return ArcticSeaIce.list_0;
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x0035076C File Offset: 0x0034E96C
		public static string smethod_4(DateTime dateTime_1)
		{
			return Application.StartupPath + "\\GIS\\SeaIce\\Arctic\\nic_autoc2012270n_pl_a.shp";
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x0035078C File Offset: 0x0034E98C
		private static List<Class377> smethod_5(DateTime dateTime_1)
		{
			List<Class377> list = new List<Class377>();
			HashSet<double> hashSet = new HashSet<double>();
			Class404 @class;
			try
			{
				@class = new Class404(ArcticSeaIce.smethod_4(DateTime.Now), ArcticSeaIce.string_0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ArcticSeaIce.string_0 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"dBase IV\"";
				@class = new Class404(ArcticSeaIce.smethod_4(DateTime.Now), ArcticSeaIce.string_0);
				ProjectData.ClearProjectError();
			}
			List<Class377> result = null;
			try
			{
				foreach (Class397 current in @class)
				{
					if (current.method_0() == Enum119.const_3)
					{
						foreach (Struct48[] current2 in ((Class400)current).method_3())
						{
							if (current2.Count<Struct48>() > 30)
							{
								List<GeoPoint> list2 = new List<GeoPoint>();
								int num = 0;
								if (current2.Count<Struct48>() > 500)
								{
									num = 2;
								}
								int num2 = 0;
								Struct48[] array = current2;
								for (int i = 0; i < array.Length; i = checked(i + 1))
								{
									Struct48 @struct = array[i];
									num2++;
									double double_ = @struct.double_1;
									hashSet.Add(double_);
									if (num == 0 || (num > 0 && num2 == num))
									{
										num2 = 0;
										list2.Add(new GeoPoint(@struct.double_0, double_));
									}
								}
								Class377 item = new Class377(list2);
								list.Add(item);
							}
						}
					}
				}
				ArcticSeaIce.nullable_0 = new double?(hashSet.Max());
				ArcticSeaIce.nullable_1 = new double?(hashSet.Min());
				result = list;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 101103", "");
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x04003829 RID: 14377
		private static ArcticSeaIce.Class269 class269_0 = new ArcticSeaIce.Class269();

		// Token: 0x0400382A RID: 14378
		public static DateTime dateTime_0 = DateTime.Parse("01/01/1995");

		// Token: 0x0400382B RID: 14379
		private static List<Class377> list_0;

		// Token: 0x0400382C RID: 14380
		private static double? nullable_0;

		// Token: 0x0400382D RID: 14381
		private static double? nullable_1;

		// Token: 0x0400382E RID: 14382
		private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x0400382F RID: 14383
		private static string string_0 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"dBase IV\"";

		// Token: 0x02000BFE RID: 3070
		private sealed class Class269
		{
			// Token: 0x0600661F RID: 26143 RVA: 0x0002C32A File Offset: 0x0002A52A
			public Class269()
			{
				this.int_1 = 10000000;
				this.concurrentDictionary_0 = new ConcurrentDictionary<string, bool>();
			}

			// Token: 0x06006620 RID: 26144 RVA: 0x003509F8 File Offset: 0x0034EBF8
			public bool? method_0(string string_0)
			{
				bool value;
				bool? result;
				if (this.concurrentDictionary_0.TryGetValue(string_0, out value))
				{
					result = new bool?(value);
				}
				else
				{
					result = null;
				}
				return result;
			}

			// Token: 0x06006621 RID: 26145 RVA: 0x00350A30 File Offset: 0x0034EC30
			public void method_1(string string_0, bool bool_0)
			{
				if (this.int_0 >= this.int_1)
				{
					this.concurrentDictionary_0 = new ConcurrentDictionary<string, bool>();
					this.int_0 = 0;
				}
				if (this.concurrentDictionary_0.TryAdd(string_0, bool_0))
				{
					this.int_0++;
				}
			}

			// Token: 0x04003830 RID: 14384
			private int int_0;

			// Token: 0x04003831 RID: 14385
			private int int_1;

			// Token: 0x04003832 RID: 14386
			private ConcurrentDictionary<string, bool> concurrentDictionary_0;
		}
	}
}
